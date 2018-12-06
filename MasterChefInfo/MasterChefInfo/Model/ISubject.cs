
namespace MasterChefInfo
{
    /// <summary>
    /// Classe de l'observable
    /// </summary>
    interface ISubject
    {
        void RegisterObserver(IObserver observer); //Pour add un observer
        void UnregisterObserver(IObserver observer); //Pour désabonner un observeur
        void NotifyObservers();
    }
}
