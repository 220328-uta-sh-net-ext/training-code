import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPokemonComponent } from './new-pokemon.component';

describe('NewPokemonComponent', () => {
  let component: NewPokemonComponent;
  let fixture: ComponentFixture<NewPokemonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewPokemonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewPokemonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
