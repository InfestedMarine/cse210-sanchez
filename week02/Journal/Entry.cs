using System;


class Entry {
    public string Date { get;}
    public string Prompt { get;}
    public string Response {get;}

    public Entry(string prompt, string response) {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;

    }

    public string ToSimpleString() {
        return $"{Date} - {Prompt}: {Response}";
    }
}