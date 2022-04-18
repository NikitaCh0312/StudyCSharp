namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Model groupModel = null;//new GroupModel();
            bool isOnline1 = groupModel?.IsOnline == false;
            bool isOnline2 = !groupModel.IsOnlineCheck();

        }
    }
}
