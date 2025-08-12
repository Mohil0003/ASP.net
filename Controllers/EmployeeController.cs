using Employee_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Data.SqlClient;

namespace Employee_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration _configuration;
        public IActionResult AccountSettings()
        {
            ViewBag.GenderList = new List<SelectListItem>
            {
                new SelectListItem { Text = "Male", Value = "Male" },
                new SelectListItem { Text = "Female", Value = "Female" },
                new SelectListItem { Text = "Other", Value = "Other" }
            };

            return View("EmployeeStandardAddEdit");
        }

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // ➡️ Add or Edit page (Index)
        public IActionResult Index()
        {
            return View("EmployeeAddEdit", new EmployeeModel());
        }

        // ➡️ Edit page (fetch employee by PK)
        public IActionResult Edit(int? EmployeeId)
        {
            EmployeeModel model = new EmployeeModel();

            if (EmployeeId != null)
            {
                string connectionString = _configuration.GetConnectionString("ConnectionString");
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                using SqlCommand cmd = new SqlCommand("PR_Employee_GetById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    model.EmployeeId = Convert.ToInt32(dr["EmployeeId"]);
                    model.FirstName = dr["FirstName"].ToString();
                    model.LastName = dr["LastName"].ToString();
                    model.Email = dr["Email"].ToString();
                    model.PhoneNumber = dr["PhoneNumber"].ToString();
                    if (dr["DateOfBirth"] != DBNull.Value)
                        model.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
                    model.Gender = dr["Gender"].ToString();
                    model.HireDate = Convert.ToDateTime(dr["HireDate"]);
                    model.JobTitle = dr["JobTitle"].ToString();
                    model.Department = dr["Department"].ToString();
                    if (dr["Salary"] != DBNull.Value)
                        model.Salary = Convert.ToDecimal(dr["Salary"]);
                    model.IsActive = Convert.ToBoolean(dr["IsActive"]);
                }
            }

            return View("EmployeeAddEdit", model);
        }

        // ➡️ Save (Insert or Update)
        [HttpPost]
        public IActionResult SaveEmployee(EmployeeModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("EmployeeAddEdit", model);
            }

            string connectionString = _configuration.GetConnectionString("ConnectionString");
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd;

            if (model.EmployeeId == 0)
            {
                // INSERT
                cmd = new SqlCommand("PR_Employee_Add", conn);
            }
            else
            {
                // UPDATE
                cmd = new SqlCommand("PR_Employee_Update", conn);
                cmd.Parameters.AddWithValue("@EmployeeId", model.EmployeeId);
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
            cmd.Parameters.AddWithValue("@LastName", model.LastName);
            cmd.Parameters.AddWithValue("@Email", model.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Gender", model.Gender ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@HireDate", model.HireDate);
            cmd.Parameters.AddWithValue("@JobTitle", model.JobTitle ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Department", model.Department ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@Salary", model.Salary ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@IsActive", model.IsActive);

            cmd.ExecuteNonQuery();

            return RedirectToAction("EmployeeList");
        }

        // ➡️ List All
        public IActionResult EmployeeList()
        {
            string connectionString = _configuration.GetConnectionString("ConnectionString");
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_Employee_GetAll";

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            return View(table);
        }

        // ➡️ Delete
        public IActionResult EmployeeDelete(int EmployeeId)
        {
            try
            {
                string connectionString = _configuration.GetConnectionString("ConnectionString");
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PR_Employee_Delete";
                cmd.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeId;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                Console.WriteLine(ex);
            }
            return RedirectToAction("EmployeeList");
        }
    }
}
