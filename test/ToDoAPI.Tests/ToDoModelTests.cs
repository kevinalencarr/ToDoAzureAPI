using ToDoAPI.Models;

namespace ToDoAPI.Tests;

public class ToDoModelTests
{
    [Fact]
    public void CanChangeName()
    {
        // Arrange
        var testToDo = new ToDoItem
        {
            Name = "Complete unit testing"
        };

        // Act
        testToDo.Name = "Complete Azure pipelines";

        // Assert
        Assert.Equal("Complete Azure", testToDo.Name);
    }
}