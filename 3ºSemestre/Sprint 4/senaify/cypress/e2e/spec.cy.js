describe("template spec", () => {
  it("passes", () => {
    cy.visit("/");
  });

  it("Verificar se está ativo", () => {
    cy.get("[aria-label='title-head']");
    cy.get("[aria-label='title-head']").should("contain", "Good morning");
  });

  it("Verificar se tem uma lista com as playlists exibidas", () => {
    cy.wait(2000);
    cy.get("[aria-label='playlist-item']").should("have.length.greaterThan", 0);
  });

  it("Clicar em uma opção de playlist e listar suas músicas", () => {
    // cy.get("[aria-label='playlist-item']").first().click();
    // cy.wait(1000);
    // cy.get("[aria-label='music-item']").should("have.length.greaterThan", 0);
  });

  // it("Clicar em uma opção de playlist e listar suas músicas2", () => {
  //   cy.get("[aria-label='music-item']").first().click();
  // });

  it("Clicar na playlist pagodeira e selecionar a musica  Vamo de Pagodinho", () => {
    cy.get("[aria-label='Pagodeira']").should("contain", "Pagodeira").click();
    cy.get("[aria-label='Vamo de Pagodin']")
      .should("contain", "Vamo de Pagodin")
      .click();
  });
});
