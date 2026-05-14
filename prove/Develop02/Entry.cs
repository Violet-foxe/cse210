class Entry
{
    // attributes
    // +_date: string
    // +_prompts: List<prompt>
    // +_response: string
    public string _date;
    public string _response;
    // public List<Prompt> _prompts;
    public string _prompt;

    // behaviors
    // + Display()
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt} \n > {_response}");
    }
}