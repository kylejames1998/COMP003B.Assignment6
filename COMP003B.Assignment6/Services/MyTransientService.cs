namespace COMP003B.Assignment6.Services
{
    public class MyTransientService
    {
        // private field
        private readonly Guid _uniqueId;

        // default constructor
        public MyTransientService()
        {
            _uniqueId = Guid.NewGuid();
        }

        // public method
        public Guid GetUniqueId()
        {
            return _uniqueId;
        }
    }
}
