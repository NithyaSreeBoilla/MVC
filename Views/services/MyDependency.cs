namespace mvcdemo.Views.services
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
        
    }
    public class MyDependency:IMyDependency
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine($"MyDependency.WriteMessage called.Message:{message}");
        }
    }
}
