namespace MordorCrueltyPlan.Models
{
    public abstract class Food
    {
        protected Food(int happinesPoint)
        {
            this.HappinesPoint = happinesPoint;
        }

        private int HappinesPoint
        {
            get ; set ; 
        }

        public int GetHappinessPoints()
        {
            return this.HappinesPoint;
        }

    }
}
