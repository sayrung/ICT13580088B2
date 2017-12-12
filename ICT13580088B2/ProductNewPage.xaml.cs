using System;
using System.Collections.Generic;
using ICT13580088B2.Models;
using Xamarin.Forms;

namespace ICT13580088B2
{
    public partial class ProductNewPage : ContentPage
    {
        Product product;
        public ProductNewPage(Product product=null)
        {
            InitializeComponent();

            this.product = product;
            okButton.Clicked += OkButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;
            category.Items.Add("เสื้อ");
            category.Items.Add("กางเกง");
            category.Items.Add("ถุงเท้า");

            if(product != null)
            {
                titleLable.Text = "แก้ไขข้อมูลสินค้า";
                nameProduct.Text = product.Name;
                detail.Text = product.Description;
                category.SelectedItem = product.Category;
                price.Text = product.SalePrice.ToString();
                nubmer.Text = product.stock.ToString();

            }
        }

        async void OkButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

            if (isOk)
            {
                if (product == null)
                {
                    product = new Product();
                    product.Name = nameProduct.Text;
                    product.Description = detail.Text;
                    product.Category = category.SelectedItem.ToString();
                    product.ProductPrice = decimal.Parse(price.Text);
                    product.SalePrice = decimal.Parse(sell.Text);
                    product.stock = int.Parse(nubmer.Text);
                    var id = App.DbHelper.AddProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ #" + id, "ตกลง");

                }
                else
                {
                    product.Name = nameProduct.Text;
                    product.Description = detail.Text;
                    product.Category = category.SelectedItem.ToString();
                    product.ProductPrice = decimal.Parse(price.Text);
                    product.SalePrice = decimal.Parse(sell.Text);
                    product.stock = int.Parse(nubmer.Text);
                    var id = App.DbHelper.UpdateProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลเรียบร้อย", "ตกลง");

                }
                await Navigation.PopModalAsync();

            }
        }
				void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

       
    }
}
