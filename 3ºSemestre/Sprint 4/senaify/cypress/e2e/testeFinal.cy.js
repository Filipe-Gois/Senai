describe("template spec", () => {
  before("passes", () => {
    cy.visit("/");
  });
  it("Redirecionar para a tela de busca", () => {
    cy.get("a[href='/Search']").click();
    cy.scrollTo("top");
  });
});
