
![.NET Core](https://github.com/ddieppa/TestSecrets/workflows/.NET%20Core/badge.svg?branch=main)
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  
  <h3 align="center">.Net Core Secrets</h3>

  <p align="center">
    Playing around with some .Net Core Secrets
  </p>
</p>

<!-- TABLE OF CONTENTS -->
## Table of Contents

- [Table of Contents](#table-of-contents)
- [About The Project](#about-the-project)
  - [Built With](#built-with)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Initialization](#initialization)
  - [Set a secret](#set-a-secret)
- [References](#references)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Acknowledgements](#acknowledgements)

<!-- ABOUT THE PROJECT -->
## About The Project

<!-- [![Product Name Screen Shot][product-screenshot]](https://example.com) -->

This is a sample project to practice a little bit how the -.Net Secrets- works

### Built With

This is a very basic Asp.net core webapi developed with

- [JetBrains Rider]

<!-- GETTING STARTED -->
## Getting Started

This is just some of the steps of the entire process, but I think are the most important ones

### Prerequisites

Experience with [ASP.NET web API]

### Initialization

1. Create the [ASP.NET web API] project with the tool of your preference
2. Move to the project folder where the _.csproj_ resides and open a Terminal there
3. To Enable the secret storage run

```sh
dotnet user-secrets init
```

1. This will create an entry in the project file

```xml
<PropertyGroup>
  <TargetFramework>netcoreapp3.1</TargetFramework>
  <UserSecretsId>79a3edd0-2092-40a2-a04d-dcb46d5ca9ed</UserSecretsId>
</PropertyGroup>
```

### Set a secret

```sh
dotnet user-secrets set "Movies:ServiceApiKey" "12345"
```

<!-- USAGE EXAMPLES -->
## References

For more in depth documentation please refer to the following:

- [How to store app secrets for your ASP .NET Core project](https://dev.to/dotnet/how-to-store-app-secrets-for-your-asp-net-core-project-2j5b)
- [Safe storage of app secrets in development in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows)

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are -greatly appreciated-.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

Daniel - [@ddieppa](https://twitter.com/ddieppa)

Project Link: [https://github.com/ddieppa/TestSecrets](https://github.com/ddieppa/TestSecrets)

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

- [GitHub Emoji Cheat Sheet](https://www.webpagefx.com/tools/emoji-cheat-sheet)
- [Img Shields](https://shields.io)
- [Choose an Open Source License](https://choosealicense.com)
- [GitHub Pages](https://pages.github.com)
- [Animate.css](https://daneden.github.io/animate.css)
- [Loaders.css](https://connoratherton.com/loaders)
- [Slick Carousel](https://kenwheeler.github.io/slick)
- [Smooth Scroll](https://github.com/cferdinandi/smooth-scroll)
- [Sticky Kit](http://leafo.net/sticky-kit)
- [JVectorMap](http://jvectormap.com)
- [Font Awesome](https://fontawesome.com)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/ddieppa/TestSecrets.svg?style=flat-square
[contributors-url]: https://github.com/ddieppa/TestSecrets/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ddieppa/TestSecrets.svg?style=flat-square
[forks-url]: https://github.com/ddieppa/TestSecrets/network/members
[stars-shield]: https://img.shields.io/github/stars/ddieppa/TestSecrets.svg?style=flat-square
[stars-url]: https://github.com/ddieppa/TestSecrets/stargazers
[issues-shield]: https://img.shields.io/github/issues/ddieppa/TestSecrets.svg?style=flat-square
[issues-url]: https://github.com/ddieppa/TestSecrets/issues
[license-shield]: https://img.shields.io/github/license/ddieppa/TestSecrets.svg?style=flat-square
[license-url]: https://github.com/ddieppa/TestSecrets/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/ddieppa
[product-screenshot]: images/screenshot.png

[JetBrains Rider]: https://www.jetbrains.com/rider/
[Visual Studio Community]: https://visualstudio.microsoft.com/vs/community/
[ASP.NET web API]: https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1
