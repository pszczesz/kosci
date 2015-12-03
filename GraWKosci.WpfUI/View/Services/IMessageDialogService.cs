namespace GraWKosci.WpfUI.View.Services {
    public interface IMessageDialogService {
        MessageDialogResult ShowYesNowDialog(string title, string text,
            MessageDialogResult defaultResult = MessageDialogResult.Yes);
    }
}