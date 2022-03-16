namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupModel groupModel = null;//new GroupModel();
            bool online1 = groupModel?.IsOnline == false;
            bool online2 = !groupModel.IsOnlineCheck();

        }
    }
}
