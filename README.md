DevDeck

DevDeck is a deck-building and collection management app for Trading Card Games (TCGs).
Built with .NET 8 Blazor WebAssembly and MudBlazor, it provides a clean, modern, and responsive experience for browsing cards, tracking collections, and crafting powerful decks.

✨ Features

📚 Card Database

Browse and search cards via external APIs (planned: Eternal APIs or other TCG providers).

Advanced filtering and sorting options.

🗂️ Collection Tracking

Track owned cards and quantities.

Visualize gaps in your collection.

🃏 Deck Builder

Create and manage decks.

Live deck statistics (mana curve, card types, etc.).

Export or share decks with others.

🚧 Future Roadmap

Deck import/export formats.

Smart deck recommendations.

Mobile/desktop support with Blazor Hybrid.

🛠️ Tech Stack

Framework: .NET 8 Blazor WebAssembly

UI Components: MudBlazor

Data Sources: External TCG APIs

🚀 Getting Started
Prerequisites

.NET 8 SDK

Setup
# Clone the repository
git clone https://github.com/Drokkzz/devdeck.git
cd devdeck/DevDeck.App

# Restore dependencies
dotnet restore

# Run the app
dotnet run




📦 Project Structure
DevDeck.App/
├── Pages/        # Main pages (Home, Cards, Decks, etc.)
├── Components/   # Reusable UI components
├── Services/     # API clients and frontend services
├── Theme/        # MudBlazor theme configuration
└── Shared/       # Layouts, NavMenu, and shared UI

DevDeck.Shared/
└── Models/       # Data models, DTOs, and shared logic
...


🤝 Contributing

Contributions, issues, and feature requests are welcome!

Open issues for feedback, bug reports, or ideas.

Fork the repo and submit pull requests.

📄 License

MIT License – free to use and modify.
