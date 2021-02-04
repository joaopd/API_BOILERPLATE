import { API_USERTemplatePage } from './app.po';

describe('API_USER App', function() {
  let page: API_USERTemplatePage;

  beforeEach(() => {
    page = new API_USERTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
