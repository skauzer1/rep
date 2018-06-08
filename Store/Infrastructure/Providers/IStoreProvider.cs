using System.Threading.Tasks;

namespace Store.Infrastructure.Providers {
    public interface IStoreProvider {
        Task GetGds();
    }
}
