namespace AspNetCoreFromTemplate.Interfaces;

/// <summary>
/// Service to provide a welcome message.
/// </summary>
public interface IWelcomeService
{
    /// <summary>
    /// Get a welcome message.
    /// </summary>
    /// <returns>A welcome message.</returns>
    /// <remarks>The time the service was created and the service instance ID.</remarks>
    string GetWelcomeMessage();
}
