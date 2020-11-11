import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NumberToWordsFromComponent } from './number-to-words-from.component';

describe('NumberToWordsFromComponent', () => {
  let component: NumberToWordsFromComponent;
  let fixture: ComponentFixture<NumberToWordsFromComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NumberToWordsFromComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NumberToWordsFromComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
