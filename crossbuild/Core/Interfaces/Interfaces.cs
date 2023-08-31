using Discord;

namespace crossbuild.Core.Interface;

public record ComponentData
{
    public string? Description { get; init; }
    public List<ComponentData> Options { get; init; }
    public bool? ServerOnly { get; init; }
    public bool? OwnerOnly { get; init; }
    public double? Cooldown { get; init; }

    public List<string>? CustomChecks { get; init; }
}

public record DataType(string Value)
{
    public static DataType String => new DataType("string");
    public static DataType Integer => new DataType("integer");
    public static DataType Number => new DataType("number");
    public static DataType Boolean => new DataType("boolean");
    public static DataType Channel => new DataType("channel");
    public static DataType Role => new DataType("role");
    public static DataType User => new DataType("user");
    public static DataType Attachment => new DataType("attachment");

    public override string ToString() => Value;
}

public record Choice
{
    public string Name { get; set; }
    public object Value { get; set; }
}

public interface ComponentOption
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool Required { get; set; }
    public DataType Type { get; set; }
    public List<Choice>? Choices { get; set; }
    public double? MinValue { get; set; }
    public double? MaxValue { get; set; }
    public int? MinLength { get; set; }
    public int? MaxLength { get; set; }
}

public class GeneratedMessage
{
    public string? Content { get; set; }
    public List<IEmbed>? Embeds { get; set; }
    public bool? IsEphemeral { get; set; }
    public List<IMessageComponent>? Components { get; set; }
}