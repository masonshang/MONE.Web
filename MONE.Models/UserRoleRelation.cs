using System.ComponentModel.DataAnnotations;

namespace MONE.Models
{
    /// <summary>
    /// 用户角色关系
    /// <remarks>
    /// 创建：2016.04.12
    /// </remarks>
    /// </summary>
    public class UserRoleRelation
    {
        [Key]
        public int RelationID { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Required()]
        public int UserID { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [Required()]
        public int RoelID { get; set; }
    }
}