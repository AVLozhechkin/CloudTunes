# CloudMusicPlayer

ASP.NET Core + Angular music player for music from Yandex.Disk/Dropbox (and Google Drive later. Maybe I will add something else because it is easy to implement)

# О проекте

- Цель проекта - изучение и отработка навыков стека ASP.NET Core + Angular + Entity Framework Core.
- Идея проекта заключается в разработке веб-приложения, которое будет представлять собой музыкальный плеер для прослушивания музыки с Яндекс.Диска и Dropbox (в дальнейшем планирую добавить поддержку GoogleDrive) с поддержкой плейлистов и очередей.
- В конечном итоге планируется развертывание веб-приложения при помощи Terraform как Serverless Container в Яндекс.Облако, но до этого ещё далеко.

# Статус проекта
- Ну относительно работает. Есть воспроизведение музыки, очередь, плейлисты и отображение дерева файлов.
- На фронте миллиард неучтенных сценариев, которые надо доделывать.
- ~~В данный момент на бэке сервисы покрыты юнит-тестами на 100%, в дальнейшем предполагается поддержание полного покрытия тестами.~~<img src="https://cdn.7tv.app/emote/633ed5cdbb95c4711938b9c7/1x.webp"/>

- Пока что тесты отменяются, так как требования к проекту генерируются в режиме реального времени.
- Логгирование минимально, так как отсутствует необходимость в нём на данном этапе разработки. Тоже самое с метриками.

# Проект в картинках

Вот так выглядит страница провайдеров, доступная после регистрации. 
Здесь пользователь может добавлять разные источники данных (провайдеры) - Яндекс.Диск, Dropbox и (чуть позже будет добавлен) Google Drive при помощи OAuth. 
На картинке представлен профиль пользователя, у которого добавлены Яндекс.Диск и Dropbox.
Возможно кнопку Update стоит назвать Sync или как-то так, но это потом.

<img src="./docs/assets/providers-page.png" height="300"/>

Это страница самого провайдера, в которую можно попасть через кнопку View на странице провайдеров. Здесь представлено дерево файлов из подключенного провайдера. Каждую песню можно либо запустить как отдельную, либо добавить в плейлист или очередь проигрывания.

<img src="./docs/assets/provider-page.png" height="300" />

Это страница одного из плейлистов. Сюда можно добавлять музыку из провайдера и запускать её одновременно, т.е. здесь можно переключаться между предыдущими и прошлыми треками, а также указывать режим воспроизведение - повторять одну песню, повторять все песни из плейлиста и не повторять вообще. Ещё есть шаффлинг песен.

<img src="./docs/assets/playlist-page.png" height="300" />
