using System.Collections;

namespace MVCDemo.Models
{
    public class SysUserRole
    {
        public int ID { get; set; }
        public string SysUserID { get; set; }
        public string SysRoleID { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysRole SysRole { get; set; }
    }
}