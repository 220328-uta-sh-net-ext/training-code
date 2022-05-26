import { ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';

import { HomePageComponent } from './home-page.component';

describe('HomePageComponent', () => {
  let component: HomePageComponent;
  let fixture: ComponentFixture<HomePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomePageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HomePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  // We can create a new test by using the it keyword and then describing a callback function to test
  // The simplest sort of test we can make

  it('should create an h1 equal to "Welcome to our Pokemon Website"', () =>{
      const h1 = fixture.debugElement.query(By.css('h1')).nativeElement;

      expect(h1.innerHTML).toBe("Welcome To Our Pokemon Website");
  })
});
