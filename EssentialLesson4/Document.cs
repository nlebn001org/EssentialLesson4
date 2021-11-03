namespace EssentialLesson4Task1
{
    class Document : InfoClass
    {

        Title title;
        Body body;
        Footer footer;

        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }

        public override void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
