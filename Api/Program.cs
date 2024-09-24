using Microsoft.AspNetCore.Mvc;
using Api.Model;

var builder = WebApplication.CreateBuilder(args);
// CORS policy tanımla
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
var app = builder.Build();

// CORS'u aktif et
app.UseCors("AllowAll");

// Endpoint tanımlama   
app.MapGet("/products", () =>
{
    var products = new List<ProductModel>
    {
    new ProductModel {
        Id = 1,
        Title = "buttermilk pancakes",
        Category = "breakfast",
        Price = 15.99m,
        Img = "./images/item-1.jpeg",
        Desc = "I'm baby woke mlkshk wolf bitters live-edge blue bottle, hammock freegan copper mug whatever cold-pressed" },
    new ProductModel {
        Id = 2,
        Title = "diner double",
        Category = "lunch",
        Price = 13.99m,
        Img = "./images/item-2.jpeg",
        Desc = "vaporware iPhone mumblecore selvage raw denim slow-carb leggings gochujang helvetica man braid jianbing. Marfa thundercats" },
    new ProductModel {
        Id = 3,
        Title = "godzilla milkshake",
        Category = "shakes",
        Price = 6.99m,
        Img = "./images/item-3.jpeg",
        Desc = "ombucha chillwave fanny pack 3 wolf moon street art photo booth before they sold out organic viral." },
    new ProductModel {
        Id = 4,
        Title = "country delight",
        Category = "breakfast",
        Price = 20.99m,
        Img = "./images/item-4.jpeg",
        Desc = "Shabby chic keffiyeh neutra snackwave pork belly shoreditch. Prism austin mlkshk truffaut" },
    new ProductModel {
        Id = 5,
        Title = "egg attack",
        Category = "lunch",
        Price = 22.99m,
        Img = "./images/item-5.jpeg",
        Desc = "franzen vegan pabst bicycle rights kickstarter pinterest meditation farm-to-table 90's pop-up" },
    new ProductModel {
        Id = 6,
        Title = "oreo dream",
        Category = "shakes",
        Price = 18.99m,
        Img = "./images/item-6.jpeg",
        Desc = "Portland chicharrones ethical edison bulb, palo santo craft beer chia heirloom iPhone everyday" },
    new ProductModel {
        Id = 7,
        Title = "bacon overflow",
        Category = "breakfast",
        Price = 8.99m,
        Img = "./images/item-7.jpeg",
        Desc = "carry jianbing normcore freegan. Viral single-origin coffee live-edge, pork belly cloud bread iceland put a bird" },
    new ProductModel {
        Id = 8,
        Title = "american classic",
        Category = "lunch",
        Price = 12.99m,
        Img = "./images/item-8.jpeg",
        Desc = "on it tumblr kickstarter thundercats migas everyday carry squid palo santo leggings. Food truck truffaut" },
    new ProductModel {
        Id = 9, Title = "quarantine buddy",
        Category = "shakes",
        Price = 16.99m,
        Img = "./images/item-9.jpeg",
        Desc = "skateboard fam synth authentic semiotics. Live-edge lyft af, edison bulb yuccie crucifix microdosing." },
     new ProductModel {
        Id = 10,
        Title = "quarantine buddy x 2",
        Category = "shakes",
        Price = 30.99m,
        Img = "./images/item-9.jpeg",
        Desc = "loremipsum dsffas ejsua lf bs ufmrbs vifşjynsyrtgstrhköy sbee sydf yetahu sgsgswt ağşçbthjaiş übyziyarek, didceybuldak" }
    };

    return Results.Ok(products);
});

app.MapPost("/orders", ([FromBody] Cart cartItems) =>
{
    // Burada gelen siparişi işleyebilirsiniz.
    return Results.Ok("Order received");
});

// TODO: breakpoint nedir, csharp içerisinde yorum satırınde todo list todo list nedir, birde cors policy nedir

// debugging yöntemi içerisinde bir araçtır aslında brakpoint ve bize kodun doğru performanslı ve düzgün yazılmasında yardımcı olur, performans ölçümüne yardımcı olur.
// frombody bir body elementinin içindeki verileri belirli bir parametreye bağlanmasını sağlar  Yani, istemci (client) tarafından gönderilen HTTP POST isteğinin gövdesindeki JSON gibi yapılandırılmış veriler, bu parametreye otomatik olarak dönüştürülür. 
// CORS (Cross-Origin Resource Sharing), şimdi şöyyle, iki tarayıcı güvenlik yüzünden birbirleriyle api, dosya paylaşmaz sayfanın kendi alanı dışındakilere de  cross-origin denir. mesela localhost:3000 ile localhost:5000 birbiriyle dosya paylaşmaz ama sen CORS kullanarak bunu paylaşılabilir kılıyosun çünkü CORS un bunlara müsade eden kendi politikaları var. 

app.Run();