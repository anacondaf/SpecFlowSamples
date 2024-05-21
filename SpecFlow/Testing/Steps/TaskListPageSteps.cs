namespace Testing.Steps;

[Binding]
public sealed class TaskListPageSteps
{
    private readonly ITaskListPage TaskListPage;

    public TaskListPageSteps(ITaskListPage taskListPage)
    {
        TaskListPage = taskListPage;
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        TaskListPage.TestSpecFlowDI().Should().Equals(result);
    }
}