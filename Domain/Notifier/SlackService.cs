﻿namespace Domain.Notifier;

public class SlackService : MessagingService
{
    private readonly IWriter _writer;

    public SlackService(IWriter writer)
    {
        _writer = writer;
    }

    public void Send(string receiver, string message)
    {
        _writer.WriteLine($"@<{receiver}>: {message}");
    }
}