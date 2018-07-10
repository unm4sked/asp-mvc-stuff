namespace episodes.Models
{
    public class Reflections
    {
        public void Test()
        {
            var user = new User("email","secret");
            var type = user.GetType();
        }
    }
}