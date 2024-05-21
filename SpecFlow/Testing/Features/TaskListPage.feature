Feature: Task List Page

User can manage their task list

@mytag
Scenario: User can access to task list page
Given a task list service
When caller hits the service TestSpecFlowDI method
Then the result should be 10