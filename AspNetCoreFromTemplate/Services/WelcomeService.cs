namespace AspNetCoreFromTemplate.Services;

using AspNetCoreFromTemplate.Interfaces;

/// <summary>
/// Service to provide a welcome message.
/// </summary>
public class WelcomeService : IWelcomeService
{
    /// <summary>
    /// Date and time the service was created.
    /// </summary>
    public readonly DateTime _serviceCreated;

    /// <summary>
    /// Unique identifier of this service.
    /// </summary>
    public readonly Guid _serviceId;

    /// <summary>
    /// Constructor for <see cref="WelcomeService"/>
    /// </summary>
    public WelcomeService()
    {
        _serviceCreated = DateTime.Now;
        _serviceId = Guid.NewGuid();
    }

    /// <inheritdoc/>
    public string GetWelcomeMessage()
    {
        return $"Welcome to Contoso! The current time is {_serviceCreated}. This service instance has an ID of {_serviceId}";
    }
}
