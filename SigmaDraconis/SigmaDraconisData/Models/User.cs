using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SigmaDraconisData.Models
{
    public class User : IEntity
    {

        public int Id
        {
            get;
            set;
        }
        [Key]
        [Required]
        public string Username
        {
            get;
            set;
        }
        [Required]
        [EmailAddress]
        public string Email
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [NotMapped]
        [DataType(DataType.Password)]
        public string PasswordAgain
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        public string PasswordTemp
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public int Active
        {
            get;
            set;
        }
        public string Signature
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string ESOUsername
        {
            get;
            set;
        }

        public IList<Reply> HasRead
        {
            get;
            set;
        }

        public IList<LoginLog> LoginLogs
        {
            get;
            set;
        }
        public IList<PollOption> VotedFor
        {
            get;
            set;
        }

    }
}
