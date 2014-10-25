using System.Collections.Generic;
using System.Linq;
using GameLibrary.Abstract;

namespace GameLibrary.Concrete {
    public class ThrowCubesHistory :IThrowHistory {
        public ThrowCubesHistory() {
            _getThrowHistory = new List<IThrow>();
        }
        private IList<IThrow> _getThrowHistory;

        public IList<IThrow> GetThrowHistory {
            get { return _getThrowHistory; }
        }

        public int GetAllThrowsScore() {
            return _getThrowHistory.Sum(item => item.GetLastThrowScore());
        }
    }
}