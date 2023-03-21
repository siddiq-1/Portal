namespace Portal.UTILITY
{
    public class ServiceResult<T>
    {
         int StatusCode { get; set; }
         string ServiceMessage { get; set; }
        T Data { get; set; }

        public void SetSuccess(T data)
        {
            StatusCode= 200;
            ServiceMessage = "Success";
            Data = data;
        }
      

        public void SetFailure(T data)
        {
            StatusCode = 500;
            ServiceMessage = "Internal Server Error";
            Data = data;
        }

        public void Success(string data)
        {
            StatusCode = 200;
            ServiceMessage = data;
        }
        public void Failure(string data)
        {
            StatusCode= 500;
            ServiceMessage = data;
        }
    }
}