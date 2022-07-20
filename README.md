# dotNetPorject

### Açıklama
  ##### Bu projede bazı bölümler basit tutulmuştur. 
  ##### Daha kapsamlı bir proje olduğunda, interface ve abstract class mantığıyla bir yapı oluşturulabilir. 
  ##### Aynı şekilde db migration ve daha kapsamlı bir ORM kullanılarak kod yazılabilir. 
  ##### Herhangi bir cache sistemi kullanmadım ama datayı diretk DB'den okumak yerine DB yormamak adına redis veya memcache üzerinden okunabilir.
  ##### Projeyi dockerize etmedim yük binecek bir yapı oluşturulduğunda dockerize edip scale edilebilir.
  ##### Swagger veya benzeri bir yapı ile API çıktısı sağlanabilir.

## Clone
    git clone https://github.com/winston-92-edr/dotnetProjectv2
    
## Kurulum
    Repository içerisinde bulunan db dosyası localhost SQL server içerisine include edildikten sonra, Solution dosyası açılıp proje sağlıklı bir şekilde çalıştırılabilir.
    
## Proje Detayları
   #### Her 5 saniyede bir verilen API üzerinden datalar okunup DB'ye yazılıyor.
   #### Projenin menü bölümünden seçilerek, 24 saatlik - 7 günlük - 30 günlük olacak şekilde datalar incelenebilir.

## Test
    RUN on: https://localhost:44379/

### Resources
    
