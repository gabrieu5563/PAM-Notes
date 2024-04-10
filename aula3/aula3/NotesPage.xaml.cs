namespace aula3;

public partial class NotesPage : ContentPage
{
    
    string path = Path.Combine(FileSystem.AppDataDirectory,"note.txt");
    string content = "";
	public NotesPage()
	{
		InitializeComponent();
        if (File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        };
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        content = FileEditor.Text;

        File.WriteAllText(path, content);
        DisplayAlert("Arquivo salvo", "Arquivo salvo com sucesso", "Ok");
    }

    private void DelButton_Clicked(object sender, EventArgs e)
    {
        if(File.Exists(path))
        {
            File.Delete(path);
            FileEditor.Text = "";
            DisplayAlert("Arquivo deletado", "Arquivo deletado com sucesso", "Ok");
        };
    }
}