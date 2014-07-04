using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaDraconisModels
{
    public class Build : IEntity
    {
        public int Health
        {
            get;
            set;
        }
        public int Stamina
        {
            get;
            set;
        }
        public int Magicka
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public virtual IList<Role> Roles
        {
            get;
            set;
        }

        public virtual IList<SkillBar> SkillBars
        {
            get;
            set;
        }
    }
}
