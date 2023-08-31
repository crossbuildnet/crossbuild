using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossbuild.Core.Abstract;

public record MessageData
{
    public string Id { get; init; }
    public string Content { get; init; }
    public string AuthorId { get; init; }
    public string? ChannelId { get; init; }
    public string? ServerId { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public DateTime? DeletedAt { get; init; }
}

public abstract class Message
{
    public string Id { get; }
    public string Content { get; }
    public string AuthorId { get; }
    public string? ChannelId { get; }
    public string? ServerId { get; }
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }
    public DateTime? DeletedAt { get; }

    protected Message(MessageData data)
    {
        Id = data.Id;
        Content = data.Content;
        AuthorId = data.AuthorId;
        ChannelId = data.ChannelId;
        ServerId = data.ServerId;
        CreatedAt = data.CreatedAt;
        UpdatedAt = data.UpdatedAt;
        DeletedAt = data.DeletedAt;
    }

    public abstract string ToString();

    public abstract string Url { get; }

    public abstract Task<string> Reply(GeneratedMessage message);

    public abstract Task Edit(GeneratedMessage message);

    public abstract Task Delete();
}