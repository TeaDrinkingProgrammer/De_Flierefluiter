using Domain.Exceptions;

namespace Domain.Sprints.SprintStates;

public class ReleasedState : SprintState
{
    private new ReleaseSprint Sprint { get; set; }
    public ReleasedState(ReleaseSprint sprint) : base(sprint)
    {
        Sprint = sprint;
    }

    public override void UploadReview(string review)
    {
        throw new Exception();
    }

    public override void ToNextState()
    {
        throw new IllegalStateAdvanceException();
    }

    public override void ReleaseSprint()
    {
        throw new IllegalStateAdvanceException();
    }

    public override void ReviewSprint()
    {
        throw new IllegalStateAdvanceException();
    }

    public override void CancelSprint()
    {
        throw new IllegalStateAdvanceException();
    }

    public override void setState()
    {
        Sprint.Project.NotifyScrumMaster("Sprint has been released");
        Sprint.Project.NotifyProductOwner("Sprint has been released");
    }
}