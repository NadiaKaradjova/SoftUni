
namespace MordorCrueltyPlan.Factories
{
    using Models;
    using Models.Moods;

    public class MoodFactory
    {
        public Mood GetMood(int hapinessPoint)
        {
            if (hapinessPoint < -5)
            {
                return new Angry();
            }
            if (hapinessPoint <= 0)
            {
                return new Sad();
            }
            if (hapinessPoint <= 15)
            {
                return new Happy();
            }            
                return new JavaScript();
           
        }
    }
}
