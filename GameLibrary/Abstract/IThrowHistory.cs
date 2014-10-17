using System.Collections.Generic;

namespace GameLibrary.Abstract {
    public interface IThrowHistory {
        IList<IThrow> GetThrowHistory { get; }
        int GetAllThrowsScore();
    }
}