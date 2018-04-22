let productService = (() => {
    function getAllProducts() {
        return remote.get('appdata', 'products', 'kinvey');
    }

    function getProductById(productId) {
        return remote.get('appdata', `products/${productId}`, 'kinvey');
    }

    return {
        getAllProducts,
        getProductById,
    }
})();