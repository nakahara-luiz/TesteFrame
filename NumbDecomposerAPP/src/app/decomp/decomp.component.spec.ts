import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DecompComponent } from './decomp.component';

describe('DecompComponent', () => {
  let component: DecompComponent;
  let fixture: ComponentFixture<DecompComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DecompComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DecompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
