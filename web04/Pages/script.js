const apiUrl = "https://localhost:5001/api/products";

// Adicionar Produto
document.getElementById("product-form").addEventListener("submit", async (e) => {
    e.preventDefault();
    const name = document.getElementById("name").value;
    const price = parseFloat(document.getElementById("price").value);
    const quantity = parseInt(document.getElementById("quantity").value);

    const response = await fetch(apiUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ name, price, quantity }),
    });
    if (response.ok) {
        alert("Produto adicionado!");
        loadProducts();
    }
});

// Carregar Produtos
async function loadProducts() {
    const response = await fetch(apiUrl);
    const products = await response.json();
    const productList = document.getElementById("product-list");
    productList.innerHTML = "";
    products.forEach((product) => {
        const li = document.createElement("li");
        li.textContent = `${product.name} - R$${product.price} - Qtd: ${product.quantity}`;
        productList.appendChild(li);
    });
}

// Inicializar
loadProducts();
