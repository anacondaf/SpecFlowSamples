namespace Testing;

public interface ITaskListPage
{
    int TestSpecFlowDI();
}

public class TaskListPage : ITaskListPage
{
    public int TestSpecFlowDI()
    {
        return 10;
    }
}