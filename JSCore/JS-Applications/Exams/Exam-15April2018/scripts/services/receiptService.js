let receiptService = (() => {

    function getActiveReceipt() {
        let userId = sessionStorage.getItem('userId');
        const endpoint = `receipts?query={"_acl.creator":"${userId}","active": "true"}`;

        return remote.get('appdata', endpoint, 'kinvey');
    }

    function getReceiptById(receiptId) {
        return remote.get('appdata', `receipts/${receiptId}`, 'kinvey');
    }

    function getEntriesByReceiptId(receiptId) {
        const endpoint = `entries?query={"receiptId":"${receiptId}"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }

    function createReceipt(total, productCount, active) {
        let data = {total, productCount, active};
        return remote.post('appdata', 'receipts', 'kinvey', data);
    }

    function addEntry(type, qty, price, receiptId) {
        let data = {type, qty, price, receiptId};
        return remote.post('appdata', 'entries', 'kinvey', data);
    }

    function commitReceipt(receiptId, total, productCount, active) {
        const endpoint = `receipts/${receiptId}`;
        let data = {total, productCount, active};
        return remote.update('appdata', endpoint, 'kinvey', data);
    }


    function deleteEntry(entryId) {
        const endpoint = `entries/${entryId}`;
        return remote.remove('appdata', endpoint, 'kinvey');
    }

    function getMyReceipts() {
        let userId = sessionStorage.getItem('userId');
        let endpoint = `receipts?query={"_acl.creator":"${userId}","active":"false"}`;
        return remote.get('appdata', endpoint, 'kinvey');
    }


    return {
        getActiveReceipt,
        getEntriesByReceiptId,
        createReceipt,
        addEntry,
        commitReceipt,
        deleteEntry,
        getMyReceipts,
        getReceiptById,
    }
})();