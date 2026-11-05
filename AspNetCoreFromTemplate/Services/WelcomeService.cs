namespace AspNetCoreFromTemplate.Services;

using AspNetCoreFromTemplate.Interfaces;

/// <summary>
/// Service to provide a welcome message.
/// </summary>
public class WelcomeService : IWelcomeService
{
    DateTime _serviceCreated;
    Guid _serviceId;

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
