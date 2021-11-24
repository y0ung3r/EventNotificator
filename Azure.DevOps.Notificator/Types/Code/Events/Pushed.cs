using Azure.DevOps.Notificator.Types.Code.Events.Checked;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Pushed
{
    public Guid? Id { get; set; }

    public string EventType { get; set; }

    public string PublisherId { get; set; }

    public string Scope { get; set; }

    public Message Message { get; set; }

    public Message DetailedMessage { get; set; }

    public CheckedInResource Resource { get; set; }

    public string ResourceVersion { get; set; }

    public ResourceDistribution ResourceDistribution { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }
}