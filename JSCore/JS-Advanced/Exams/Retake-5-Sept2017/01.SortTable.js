function sort(colIndex, descending) {
    let trs = $('tbody tr').sort(sortTrs);
    function sortTrs(a, b) {
        let aVal;
        let bVal;
        if (colIndex === 0) {
            aVal = a.firstElementChild.innerHTML;
            bVal = b.firstElementChild.innerHTML;
        } else {
            aVal = Number(a.lastElementChild.innerHTML);
            bVal = Number(b.lastElementChild.innerHTML);
        }

        if (descending) {
            if (aVal > bVal) {
                return -1;
            }

            if (aVal < bVal) {
                return 1;
            }

            return 0
        } else {
            if (aVal > bVal) {
                return 1;
            }

            if (aVal < bVal) {
                return -1;
            }

            return 0
        }
    }

    let body = $('tbody');

    console.log(trs);
    for (let tr of trs) {
        body.append(tr);
    }
}
