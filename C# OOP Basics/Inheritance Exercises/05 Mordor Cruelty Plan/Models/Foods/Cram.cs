using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorCrueltyPlan.Models.Foods
{
    public class Cram : Food
    {
        private const int HappinessPoints = 2;

        public Cram() : base(HappinessPoints)
        {
        }
    }
}
