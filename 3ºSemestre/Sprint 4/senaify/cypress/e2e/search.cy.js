describe("template spec", () => {
  let musicaProcurada;

  before("passes", () => {
    cy.visit("/");
  });
  it("Redirecionar para a tela de busca", () => {
    cy.get("a[href='/Search']").click();
    cy.scrollTo("top");
  });

  it("Procurando uma música em específico", () => {
    cy.get("[data-testid='campoBusca']").type("Trem bala");
    cy.get("[aria-label='music-item']").should("have.length.greaterThan", 0);
  });

  it("Clicar na música desejada", () => {
    musicaProcurada = cy
      .get("[aria-label='music-item']")
      .contains("Ana Vilela");

    musicaProcurada.click();
  });

  it("Clicar no curtir da música", () => {
    // musicaProcurada.then((item) => {
    //   item.find("[data-testid='icon-button']").first().click();
    // });
    cy.get(musicaProcurada).get("[data-testid='icon-button']").first().click();
  });
});
