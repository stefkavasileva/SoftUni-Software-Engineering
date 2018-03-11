//80/100
class Task {
    constructor(title, deadline) {
        this.title = title;
        this._deadline = deadline;
        this.status = 'Open';

    }

    get isOverdue() {
        if (this.status === 'Complete'){
            return false;
        }

        return this.deadline < Date.now();
    }

    set deadline(value) {
        if (value < Date.now()) {
            throw new Error();
        }
        this._deadline = value;
    }

    get deadline() {
        return this._deadline;
    }

    static comparator(a, b) { //==>> not working
        if(a < b){
            return -1;
        }

        if(b > a){
            return 1;
        }

        return 0;
    }

    toString() {
        let statusIcon;
        if (this.status === 'Open') {
            statusIcon = '\u2731';
        } else if (this.status === 'In Progress') {
            statusIcon = '\u219D';
        } else if (this.status === 'Complete' && !this.isOverdue) {
            statusIcon = '\u2714';
        } else if (this.status !== 'Complete' && this.isOverdue) {
            statusIcon = '\u26A0';
        }

        let deadlineResult = this.isOverdue ? '(overdue)' : `(deadline: ${this.deadline})`;
        return `[${statusIcon}] ${this.title} ${deadlineResult}`;
    }
}

/*static comparator(a, b) {
        if (Task.statusRank === undefined) {
            Object.defineProperty(Task, 'statusRank', {
                value: {
                    'Open': 2,
                    'In Progress': 1,
                    'Complete': 3
                },
                configurable: false,
                enumerable: false,
                writable: false
            });
        }
        let rankA = a.isOverdue ? 0 : Task.statusRank[a.status];
        let rankB = b.isOverdue ? 0 : Task.statusRank[b.status];
        if (rankA - rankB !== 0) {
            return rankA - rankB;
        }
        return a.deadline - b.deadline;
    }
*/
