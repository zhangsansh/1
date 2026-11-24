using SqlSugar;

namespace _1
{
    // 部门
    [SugarTable("department")]
    public class Department
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "dept_name")]
        public string DeptName { get; set; }

        [SugarColumn(ColumnName = "dept_code")]
        public string DeptCode { get; set; }

        [SugarColumn(ColumnName = "parent_id")]
        public int ParentId { get; set; }

        [SugarColumn(ColumnName = "manager_id")]
        public int? ManagerId { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 岗位
    [SugarTable("post")]
    public class Post
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "post_name")]
        public string PostName { get; set; }

        [SugarColumn(ColumnName = "post_code")]
        public string PostCode { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 产线
    [SugarTable("production_line")]
    public class ProductionLine
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "line_name")]
        public string LineName { get; set; }

        [SugarColumn(ColumnName = "line_code")]
        public string LineCode { get; set; }

        [SugarColumn(ColumnName = "dept_id")]
        public int? DeptId { get; set; }

        [SugarColumn(ColumnName = "status")]
        public int Status { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 员工
    [SugarTable("employee")]
    public class Employee
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "emp_no")]
        public string EmpNo { get; set; }

        [SugarColumn(ColumnName = "emp_name")]
        public string EmpName { get; set; }

        [SugarColumn(ColumnName = "gender")]
        public string Gender { get; set; }

        [SugarColumn(ColumnName = "phone")]
        public string Phone { get; set; }

        [SugarColumn(ColumnName = "dept_id")]
        public int? DeptId { get; set; }

        [SugarColumn(ColumnName = "post_id")]
        public int? PostId { get; set; }

        [SugarColumn(ColumnName = "line_id")]
        public int? LineId { get; set; }

        [SugarColumn(ColumnName = "entry_date")]
        public string EntryDate { get; set; }

        [SugarColumn(ColumnName = "status")]
        public int Status { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 权限
    [SugarTable("permission")]
    public class Permission
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "perm_name")]
        public string PermName { get; set; }

        [SugarColumn(ColumnName = "perm_code")]
        public string PermCode { get; set; }

        [SugarColumn(ColumnName = "perm_type")]
        public string PermType { get; set; }

        [SugarColumn(ColumnName = "parent_id")]
        public int ParentId { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 工资
    [SugarTable("salary")]
    public class Salary
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "emp_id")]
        public int EmpId { get; set; }

        [SugarColumn(ColumnName = "salary_month")]
        public string SalaryMonth { get; set; }

        [SugarColumn(ColumnName = "base_salary")]
        public decimal BaseSalary { get; set; }

        [SugarColumn(ColumnName = "bonus")]
        public decimal Bonus { get; set; }

        [SugarColumn(ColumnName = "deduction")]
        public decimal Deduction { get; set; }

        [SugarColumn(ColumnName = "total_salary")]
        public decimal TotalSalary { get; set; }

        [SugarColumn(ColumnName = "pay_status")]
        public int PayStatus { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 系统用户
    [SugarTable("sys_user")]
    public class SysUser
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "employee_id")]
        public int? EmployeeId { get; set; }

        [SugarColumn(ColumnName = "username")]
        public string Username { get; set; }

        [SugarColumn(ColumnName = "password")]
        public string Password { get; set; }

        [SugarColumn(ColumnName = "avatar")]
        public string Avatar { get; set; }

        [SugarColumn(ColumnName = "status")]
        public int Status { get; set; }

        [SugarColumn(ColumnName = "last_login_time")]
        public string LastLoginTime { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 角色
    [SugarTable("sys_role")]
    public class SysRole
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "role_name")]
        public string RoleName { get; set; }

        [SugarColumn(ColumnName = "role_code")]
        public string RoleCode { get; set; }

        [SugarColumn(ColumnName = "remark")]
        public string Remark { get; set; }

        [SugarColumn(ColumnName = "create_time")]
        public string CreateTime { get; set; }
    }

    // 用户角色中间表
    [SugarTable("user_role")]
    public class UserRole
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "user_id")]
        public int? UserId { get; set; }

        [SugarColumn(ColumnName = "role_id")]
        public int? RoleId { get; set; }
    }

    // 角色权限中间表
    [SugarTable("role_permission")]
    public class RolePermission
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }

        [SugarColumn(ColumnName = "role_id")]
        public int? RoleId { get; set; }

        [SugarColumn(ColumnName = "perm_id")]
        public int? PermId { get; set; }
    }

    // 视图实体（只读）
    [SugarTable("v_emp_full")]
    public class VEmpFull
    {
        [SugarColumn(ColumnName = "emp_id")]
        public int EmpId { get; set; }

        [SugarColumn(ColumnName = "emp_no")]
        public string EmpNo { get; set; }

        [SugarColumn(ColumnName = "emp_name")]
        public string EmpName { get; set; }

        [SugarColumn(ColumnName = "gender")]
        public string Gender { get; set; }

        [SugarColumn(ColumnName = "phone")]
        public string Phone { get; set; }

        [SugarColumn(ColumnName = "entry_date")]
        public string EntryDate { get; set; }

        [SugarColumn(ColumnName = "emp_status_text")]
        public string EmpStatusText { get; set; }

        [SugarColumn(ColumnName = "dept_id")]
        public int? DeptId { get; set; }

        [SugarColumn(ColumnName = "dept_name")]
        public string DeptName { get; set; }

        [SugarColumn(ColumnName = "dept_code")]
        public string DeptCode { get; set; }

        [SugarColumn(ColumnName = "post_id")]
        public int? PostId { get; set; }

        [SugarColumn(ColumnName = "post_name")]
        public string PostName { get; set; }

        [SugarColumn(ColumnName = "post_code")]
        public string PostCode { get; set; }

        [SugarColumn(ColumnName = "line_id")]
        public int? LineId { get; set; }

        [SugarColumn(ColumnName = "line_name")]
        public string LineName { get; set; }

        [SugarColumn(ColumnName = "line_code")]
        public string LineCode { get; set; }

        [SugarColumn(ColumnName = "user_id")]
        public int? UserId { get; set; }

        [SugarColumn(ColumnName = "username")]
        public string Username { get; set; }

        [SugarColumn(ColumnName = "last_login_time")]
        public string LastLoginTime { get; set; }

        [SugarColumn(ColumnName = "user_status_text")]
        public string UserStatusText { get; set; }

        [SugarColumn(ColumnName = "role_names")]
        public string RoleNames { get; set; }

        [SugarColumn(ColumnName = "salary_month")]
        public string SalaryMonth { get; set; }

        [SugarColumn(ColumnName = "base_salary")]
        public decimal? BaseSalary { get; set; }

        [SugarColumn(ColumnName = "bonus")]
        public decimal? Bonus { get; set; }

        [SugarColumn(ColumnName = "deduction")]
        public decimal? Deduction { get; set; }

        [SugarColumn(ColumnName = "total_salary")]
        public decimal? TotalSalary { get; set; }

        [SugarColumn(ColumnName = "pay_status_text")]
        public string PayStatusText { get; set; }
    }
}
