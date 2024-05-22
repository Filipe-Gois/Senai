let goodMorning;
let playlist;
let music;
let musicaFavorita;
describe("Visualizar playlists e executar uma música:", () => {
  before("passes", () => {
    cy.visit("/");
  });
  it("Redirecionar para a tela home", () => {
    cy.get("a[href='/Home']").click();

    cy.scrollTo("top");
  });
  it("Ver o Good morning", () => {
    goodMorning = cy
      .get("[aria-label='title-head']")
      .should("contain", "Good morning");
  });

  it("eu vejo uma lista de playlists", () => {
    cy.get("[aria-label='playlist-item']").should("have.length.greaterThan", 0);
  });

  it("eu clico na primeira playlist", () => {
    playlist = cy.get("[aria-label='playlist-item']").first().click();
  });

  it("eu vejo uma lista de músicas", () => {
    music = cy
      .get("[aria-label='music-item']")
      .should("have.length.greaterThan", 0);
  });

  it("eu clico na primeira música", () => {
    music = cy.get("[aria-label='music-item']").first().click();
  });

  it("a música começa a tocar", () => {
    music = cy.get("[aria-label='music-item']").first().click();
  });
});
describe("Navegar entre playlists e executar outra música:", () => {
  it("eu volto para a listagem de playlists", () => {
    cy.wait(1000);
    cy.visit("/");
  });
  it("eu clico na segunda playlist", () => {
    playlist = cy.get("[aria-label='playlist-item']").eq(1).click();
  });

  it("eu vejo uma lista de músicas", () => {
    cy.get("[aria-label='music-item']").should("have.length.greaterThan", 0);
  });
  it("eu clico na primeira música", () => {
    music = cy.get("[aria-label='music-item']").first().click();
  });

  it("a música começa a tocar ", () => {
    music = cy.get("[aria-label='music-item']").first().click();
  });
});

describe("Procurar e favoritar uma música", () => {
  it("que eu estou na tela de Pesquisa", () => {
    cy.wait(1000);
    cy.get("a[href='/Search']").click();
  });

  it("eu procuro por uma música Judas", () => {
    cy.get("[data-testid='campoBusca']").type("Casca de bala");
  });

  it("eu clico na primeira música dos resultados", () => {
    music = cy.get("[aria-label='music-item-search']").first().click();
  });

  it("eu clico para favoritar a música", () => {
    cy.get("[data-testid='icon-button-search']").first().click();
  });
});

describe("Verificar música favoritada na tela de Favoritos", () => {
  it("que eu estou na tela de Favoritos", () => {
    cy.wait(1000);
    cy.get("a[href='/Favorites']").click();
  });

  it("eu clico na música favoritada", () => {
    cy.get("[aria-label='music-item-fav-titulo']").first().click();
  });
});
