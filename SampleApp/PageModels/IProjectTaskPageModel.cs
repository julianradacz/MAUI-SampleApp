using CommunityToolkit.Mvvm.Input;
using SampleApp.Models;

namespace SampleApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}