package de.bib.dozvjg.probeklausur;

public class ShoppingMemo {
    private String product;
    private int quantity;
    private long id;
    private float price;


    public ShoppingMemo(String product, int quantity, long id, float price) {

        this.product = product;
        this.quantity = quantity;
        this.id = id;
        this.price = price;
    }


    public String getProduct() {
        return product;
    }

    public void setProduct(String product) {
        this.product = product;
    }


    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }


    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }


    @Override
    public String toString() {
        String output = quantity + " x " + product + " = " + Float.toString(quantity*price).replace('.',',') + " €";
        return output;
    }
}

