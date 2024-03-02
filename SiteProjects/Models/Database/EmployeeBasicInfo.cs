using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class EmployeeBasicInfo
    {
        [Key]
        public int EmpId { get; set; }
        [MaxLength(200)]
        public string EmpName { get; set; }
        [MaxLength(200)]
        public string EmpFatherName { get; set; }=null;
        [MaxLength(200)]
        public string EmpMotherName { get; set; } = null;
        [MaxLength(200)]
        public string EmpSpouseName { get; set; } = null;
        [MaxLength(200)]
        public string EmpNID { get; set; }
        [MaxLength(200)]
        public string EmpPassport { get; set; } = null;
        [MaxLength(200)]
        public string EmpTIN { get; set; } = null;
        [MaxLength(200)]
        public string EmpNationality { get; set; } = null;
        [MaxLength(200)]
        public string EmpReligion { get; set; }
        [MaxLength(200)]
        public string EmpBloodGroup { get; set; }
        [MaxLength(200)]
        public string EmpMaritalStatus { get; set; }
        [MaxLength(200)]
        public string EmpGender { get; set; }
        public int? InfId { get; set; } = null;//BankId
        public string JobLocation { get; set; }
        public string PresentAddress { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public DateOnly ResignDate { get; set; }
        public DateOnly DateOfJoin { get; set; }
        public DateTime ActionDate { get; set; }
        public byte[] Photo { get; set; }
        public int ActionBy { get; set; }
        public bool IsActive { get; set; }

    }
}
