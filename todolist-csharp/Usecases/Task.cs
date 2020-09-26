using System;

namespace JHashimoto.Todolist.RegisterTask {
    public class Task {
        private DateTime _limit;
        public bool IsExpired {
            get { return _limit < DateTime.Today; }
        }

        public Task (DateTime limit) {
            _limit = limit;
        }
    }
}